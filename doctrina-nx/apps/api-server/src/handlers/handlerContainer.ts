import { Handler } from "./handler"
import { IRequest } from "../requests/request"
import { IResponse } from "../responses/response"

class HandlerContainer {
    private kernel: { [key: string]: Handler<IRequest, IResponse> } = {};

    RegisterHandler<IRequest, IResponse>(requestName: string, handler: Handler<IRequest, IResponse>) {
        this.kernel[`${requestName}`] = handler;
    }

    ResolveHandler<IRequest, IResponse>(requestName: string, request: IRequest):
    Handler<IRequest, IResponse> {
        return <Handler<IRequest, IResponse>>this.kernel[`${requestName}`];
    }
}

let singletonContainer = new HandlerContainer();
export default singletonContainer;