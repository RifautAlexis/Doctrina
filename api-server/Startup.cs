using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using api_server.Data;
using Microsoft.EntityFrameworkCore;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using FluentValidation.AspNetCore;
using api_server.Presentation.Middleware;
using api_server.Contract.Requests;
using api_server.Contract.Responses;
using api_server.Handlers;
using Microsoft.Extensions.Hosting;

namespace api_server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddScoped<
                IHandler<SigninRequest, AuthenticationResponse>,
                SigninHandler>();
            services.AddScoped<
                IHandler<SearchArticlesRequest, ArticlesResponse>,
                GetArticlesHandler>();
            services.AddScoped<
                IHandler<GetArticleByIdRequest, ArticleResponse>,
                GetArticleByIdHandler>();
            services.AddScoped<
                IHandler<GetAllArticleRequest, ArticlesResponse>,
                GetAllArticleHandler>();
            services.AddScoped<
                IHandler<IsUniqueTitleRequest, BooleanResponse>,
                IsUniqueTitleHandler>();
            services.AddScoped<
                IHandler<CreateArticleRequest, IdResponse>,
                CreateArticleHandler>();
            services.AddScoped<
                IHandler<GetAllTagRequest, TagsResponse>,
                GetAllTagHandler>();
            services.AddScoped<
                IHandler<DeleteArticleRequest, BooleanResponse>,
                DeleteArticleHandler>();
            services.AddScoped<
                IHandler<EditArticleRequest, IdResponse>,
                EditArticleHandler>();
            services.AddScoped<
                IHandler<CreateTagRequest, IdResponse>,
                CreateTagHandler>();
            services.AddScoped<
                IHandler<DeleteTagRequest, BooleanResponse>,
                DeleteTagHandler>();
            services.AddScoped<
                IHandler<IsUniqueTitleRequest, BooleanResponse>,
                IsUniqueTitleHandler>();
            services.AddScoped<
                IHandler<EditTagRequest, IdResponse>,
                EditTagHandler>();

            services.AddControllers()
                .ConfigureApiBehaviorOptions(options => options.SuppressInferBindingSourcesForParameters = true)
                .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<Startup>());

            services.AddSingleton(Configuration);

            services.AddDbContext<ApplicationDBContext>(options => options.UseMySql(Configuration.GetConnectionString("DefaultConnection"),
                options => options.EnableRetryOnFailure()
            ));

            services.AddCors();

            // configure jwt authentication
            var secret = Configuration.GetSection("Settings:Secret").Value;
            var key = Encoding.ASCII.GetBytes(secret);

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateLifetime = true
                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMiddleware<ExceptionMiddleware>();

            app.UseRouting();

            app.UseCors(options => options
                .SetIsOriginAllowed(x => _ = true)
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials());

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
