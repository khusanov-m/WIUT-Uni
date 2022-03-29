import express from 'express';
import morgan from 'morgan';
import cors from 'cors';

export * from './error.middleware';

export const initMiddlewares = (app: express.Application ): void => {
  app.use(morgan('dev'));
  app.use(cors());
  app.use(express.json());
  app.use(express.static('public'));
  app.use(express.urlencoded({ extended: true }));
};
