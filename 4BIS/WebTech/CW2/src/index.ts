import express from 'express';

import routes from './routes';

import { initMiddlewares, errorHandler } from './middlewares';

const app: express.Application = express();

initMiddlewares(app);

app.use('/api/v1', routes);

app.use('*', (req, res) => {
  res.status(404).send('404 Not Found');
});

app.use(errorHandler);

export default app;
