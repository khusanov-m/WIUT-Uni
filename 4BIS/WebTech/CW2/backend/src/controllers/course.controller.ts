import { Request, Response } from 'express';

import { Course } from '../models/course.model';

export const getAllCourses = async (req: Request, res: Response) => {
  try {
    const courses = await Course.find({});

    res.status(200).json({
      status: 'success',
      result: courses.length,
      courses: courses,
    });
  } catch (err) {
    throw {
      status: err.status,
      message:
        "Something went wrong. Couldn't get all courses or you don't have permission",
      reason: err,
    };
  }
};

export const getCourse = async (req: Request, res: Response) => {
  try {
    const courses = await Course.findById(req.params.id);

    res.status(200).json({
      status: 'success',
      data: {
        courses,
      },
    });
  } catch (err) {
    res.status(404).json({
      status: 'fail',
      message: err,
    });
  }
};

export const createCourse = async (req: Request, res: Response) => {
  try {
    const newCourse = await Course.create(req.body);

    res.status(201).json({
      status: 'success',
      data: {
        course: newCourse,
      },
    });
  } catch (err) {
    throw {
      status: err.status,
      message: 'All required fields should be filled',
      reason: err,
    };
  }
};

export const updateCourse = async (req: Request, res: Response) => {
  try {
    const course = await Course.findByIdAndUpdate(req.params.id, req.body, {
      new: true,
      runValidators: true,
    });

    res.status(200).json({
      status: 'success',
      data: {
        course,
      },
    });
  } catch (err) {
    res.status(404).json({
      status: 'fail',
      message: err,
    });
  }
};

export const deleteCourse = async (req: Request, res: Response) => {
  try {
    await Course.findByIdAndDelete(req.params.id);

    res.status(200).json({
      status: 'success',
      data: null,
    });
  } catch (err) {
    res.status(404).json({
      status: 'fail',
      message: err,
    });
  }
};

export const getFavs = async (req: Request, res: Response) => {
  try {
    const favs = await Course.find({ isFavorite: true });

    res.status(200).json({
      status: 'success',
      data: favs,
    });
  } catch (err) {
    res.status(404).json({
      status: 'fail',
      message: err,
    });
  }
};
