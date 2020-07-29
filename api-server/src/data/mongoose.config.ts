import { MongooseOptionsFactory, MongooseModuleOptions } from "@nestjs/mongoose"
require('dotenv').config()

export class MongooseConfig implements MongooseOptionsFactory {
    
    createMongooseOptions(): MongooseModuleOptions {
        return {
            uri: process.env.DATABASE_URI
        }
    }
}