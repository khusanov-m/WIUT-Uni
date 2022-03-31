import { Router } from 'express';
import * as courseController from '../controllers/course.controller';
const router: Router = Router();

router
  .route('/')
  .get(courseController.getAllCourses)
  .post(courseController.createCourse);

router.route('/favs').get(courseController.getFavs);

router
  .route('/:id')
  .get(courseController.getCourse)
  .put(courseController.updateCourse)
  .delete(courseController.deleteCourse);

export default router;
