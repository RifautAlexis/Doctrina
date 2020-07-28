import { DataModule } from './data/data.module';
import { Module } from '@nestjs/common';

@Module({
  imports: [
    DataModule,
  ],
  controllers: [],
  providers: [],
})
export class AppModule { }
