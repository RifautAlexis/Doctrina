import { MongooseOptionsFactory, MongooseModuleOptions } from "@nestjs/mongoose"
require('dotenv').config()

export class MongooseConfig implements MongooseOptionsFactory {

    constructor() {}
    
    createMongooseOptions(): MongooseModuleOptions {
        return {
            uri: process.env.DATABASE_URI
        }
    }
}