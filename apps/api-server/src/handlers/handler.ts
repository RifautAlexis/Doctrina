export interface Handler<IRequest, IResponse> {
    Handle(request: IRequest): Promise<IResponse>;
}