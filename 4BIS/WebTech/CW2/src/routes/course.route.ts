import { Router } from 'express';
import * as courseController from '../controllers/course.controller';
const router: Router = Router();

router
  .route('/')
  .get(courseController.getAllCourses)
  .post(courseController.createCourse);

router
  .route('/:id')
  .get(courseController.getCourse)
  .patch(courseController.updateCourse)
  .delete(courseController.deleteCourse);

export default router;
