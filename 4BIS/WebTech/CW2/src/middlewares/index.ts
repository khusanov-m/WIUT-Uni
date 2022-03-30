import express from 'express';
import morgan from 'morgan';
import cors from 'cors';
import path from 'path';

export * from './error.middleware';

export const initMiddlewares = (app: express.Application): void => {
  app.use(morgan('dev'));
  app.use(cors());
  app.use(express.json());
  app.use('/static', express.static(path.join(`${__dirname}/../public`)));
  app.use(express.static('public'));
  app.use(express.urlencoded({ extended: true }));
  app.set('view engine', 'pug');
  app.set('views', path.join(`${__dirname}/../views`));
};
