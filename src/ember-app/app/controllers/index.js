import Controller from '@ember/controller';
import { computed } from '@ember/object';

export default Controller.extend({
  sitemap: computed('i18n.locale', function () {
    let i18n = this.get('i18n');

    return {
      nodes: [
        {
          link: 'index',
          icon: 'home',
          caption: i18n.t('forms.application.sitemap.index.caption'),
          title: i18n.t('forms.application.sitemap.index.title'),
          children: null
        }, {
          link: null,
          icon: 'list',
          caption: i18n.t('forms.application.sitemap.kyrs18.caption'),
          title: i18n.t('forms.application.sitemap.kyrs18.title'),
          children: [{
            link: 'i-i-s-kyrs18-оператор-l',
            caption: i18n.t('forms.application.sitemap.kyrs18.i-i-s-kyrs18-оператор-l.caption'),
            title: i18n.t('forms.application.sitemap.kyrs18.i-i-s-kyrs18-оператор-l.title'),
            icon: 'tags',
            children: null
          }, {
            link: 'i-i-s-kyrs18-маршрут-l',
            caption: i18n.t('forms.application.sitemap.kyrs18.i-i-s-kyrs18-маршрут-l.caption'),
            title: i18n.t('forms.application.sitemap.kyrs18.i-i-s-kyrs18-маршрут-l.title'),
            icon: 'chart line',
            children: null
          }, {
            link: 'i-i-s-kyrs18-обслуживание-l',
            caption: i18n.t('forms.application.sitemap.kyrs18.i-i-s-kyrs18-обслуживание-l.caption'),
            title: i18n.t('forms.application.sitemap.kyrs18.i-i-s-kyrs18-обслуживание-l.title'),
            icon: 'table',
            children: null
          }, {
            link: 'i-i-s-kyrs18-покупатель-l',
            caption: i18n.t('forms.application.sitemap.kyrs18.i-i-s-kyrs18-покупатель-l.caption'),
            title: i18n.t('forms.application.sitemap.kyrs18.i-i-s-kyrs18-покупатель-l.title'),
            icon: 'file',
            children: null
          }, {
            link: 'i-i-s-kyrs18-покупка-билета-l',
            caption: i18n.t('forms.application.sitemap.kyrs18.i-i-s-kyrs18-покупка-билета-l.caption'),
            title: i18n.t('forms.application.sitemap.kyrs18.i-i-s-kyrs18-покупка-билета-l.title'),
            icon: 'chart line',
            children: null
          }, {
            link: 'i-i-s-kyrs18-перевозчик-l',
            caption: i18n.t('forms.application.sitemap.kyrs18.i-i-s-kyrs18-перевозчик-l.caption'),
            title: i18n.t('forms.application.sitemap.kyrs18.i-i-s-kyrs18-перевозчик-l.title'),
            icon: 'calendar',
            children: null
          }, {
            link: 'i-i-s-kyrs18-билет-касса-l',
            caption: i18n.t('forms.application.sitemap.kyrs18.i-i-s-kyrs18-билет-касса-l.caption'),
            title: i18n.t('forms.application.sitemap.kyrs18.i-i-s-kyrs18-билет-касса-l.title'),
            icon: 'book',
            children: null
          }]
        }
      ]
    };
  }),
})