import { Router } from 'express';

import courseRoutes from './course.route';

const router: Router = Router();
router.route('/').get((req, res) => {
  res.redirect('/courses');
})
router.use('/courses', courseRoutes);

export default router;
