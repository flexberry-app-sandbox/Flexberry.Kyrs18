import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  адрес: DS.attr('string'),
  наименование: DS.attr('string')
});

export let ValidationRules = {
  адрес: {
    descriptionKey: 'models.i-i-s-kyrs18-билет-касса.validations.адрес.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  наименование: {
    descriptionKey: 'models.i-i-s-kyrs18-билет-касса.validations.наименование.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('БилетКассаE', 'i-i-s-kyrs18-билет-касса', {
    наименование: attr('Наименование', { index: 0 }),
    адрес: attr('Адрес', { index: 1 })
  });

  modelClass.defineProjection('БилетКассаL', 'i-i-s-kyrs18-билет-касса', {
    наименование: attr('Наименование', { index: 0 }),
    адрес: attr('Адрес', { index: 1 })
  });
};
