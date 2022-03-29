import { ErrorRequestHandler } from 'express';

export const errorHandler: ErrorRequestHandler = (err, req, res, next) => {
  if (err.status) {
    res.status(err.status).json({
      status: 'fail',
      message: err.message,
    });
  } else {
    res.status(500).json({
      status: 'fail',
      message: err.message,
    });
  }
};
