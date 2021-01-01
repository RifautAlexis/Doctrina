import container from "./handlerContainer";

class Executor {

    async Execute<IRequest, IResponse>(requestName: string, request: IRequest): Promise<IResponse> {
        let handler = container.ResolveHandler<IRequest, IResponse>(requestName);
        return await handler.Handle(request);
    }

}

let executor = new Executor();
export default executor;