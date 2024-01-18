import EmberRouter from '@ember/routing/router';
import config from './config/environment';

const Router = EmberRouter.extend({
  location: config.locationType
});

Router.map(function () {
  this.route('i-i-s-kyrs18-билет-касса-l');
  this.route('i-i-s-kyrs18-билет-касса-e',
  { path: 'i-i-s-kyrs18-билет-касса-e/:id' });
  this.route('i-i-s-kyrs18-билет-касса-e.new',
  { path: 'i-i-s-kyrs18-билет-касса-e/new' });
  this.route('i-i-s-kyrs18-маршрут-l');
  this.route('i-i-s-kyrs18-маршрут-e',
  { path: 'i-i-s-kyrs18-маршрут-e/:id' });
  this.route('i-i-s-kyrs18-маршрут-e.new',
  { path: 'i-i-s-kyrs18-маршрут-e/new' });
  this.route('i-i-s-kyrs18-обслуживание-l');
  this.route('i-i-s-kyrs18-обслуживание-e',
  { path: 'i-i-s-kyrs18-обслуживание-e/:id' });
  this.route('i-i-s-kyrs18-обслуживание-e.new',
  { path: 'i-i-s-kyrs18-обслуживание-e/new' });
  this.route('i-i-s-kyrs18-оператор-l');
  this.route('i-i-s-kyrs18-оператор-e',
  { path: 'i-i-s-kyrs18-оператор-e/:id' });
  this.route('i-i-s-kyrs18-оператор-e.new',
  { path: 'i-i-s-kyrs18-оператор-e/new' });
  this.route('i-i-s-kyrs18-перевозчик-l');
  this.route('i-i-s-kyrs18-перевозчик-e',
  { path: 'i-i-s-kyrs18-перевозчик-e/:id' });
  this.route('i-i-s-kyrs18-перевозчик-e.new',
  { path: 'i-i-s-kyrs18-перевозчик-e/new' });
  this.route('i-i-s-kyrs18-покупатель-l');
  this.route('i-i-s-kyrs18-покупатель-e',
  { path: 'i-i-s-kyrs18-покупатель-e/:id' });
  this.route('i-i-s-kyrs18-покупатель-e.new',
  { path: 'i-i-s-kyrs18-покупатель-e/new' });
  this.route('i-i-s-kyrs18-покупка-билета-l');
  this.route('i-i-s-kyrs18-покупка-билета-e',
  { path: 'i-i-s-kyrs18-покупка-билета-e/:id' });
  this.route('i-i-s-kyrs18-покупка-билета-e.new',
  { path: 'i-i-s-kyrs18-покупка-билета-e/new' });
});

export default Router;
