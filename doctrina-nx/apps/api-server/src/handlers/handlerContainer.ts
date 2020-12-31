import { Handler } from "./handler"
import { IRequest } from "../contract/requests/request"
import { IResponse } from "@doctrina-nx/responses";

class HandlerContainer {
    private kernel: { [key: string]: Handler<IRequest, IResponse> } = {};

    RegisterHandler<IRequest, IResponse>(requestName: string, handler: Handler<IRequest, IResponse>) {
        this.kernel[`${requestName}`] = handler;
    }

    ResolveHandler<IRequest, IResponse>(requestName: string):
    Handler<IRequest, IResponse> {
        return <Handler<IRequest, IResponse>>this.kernel[`${requestName}`];
    }
}

let singletonContainer = new HandlerContainer();
export default singletonContainer;