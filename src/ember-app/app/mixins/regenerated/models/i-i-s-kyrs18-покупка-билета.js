import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  варПолучБилет: DS.attr('i-i-s-kyrs18-вариант'),
  времяПокупки: DS.attr('string'),
  датаПокупки: DS.attr('date', { defaultValue() { return new Date(); } }),
  билетКасса: DS.belongsTo('i-i-s-kyrs18-билет-касса', { inverse: null, async: false }),
  покупатель: DS.belongsTo('i-i-s-kyrs18-покупатель', { inverse: null, async: false }),
  информация: DS.hasMany('i-i-s-kyrs18-информация', { inverse: 'покупкаБилета', async: false })
});

export let ValidationRules = {
  варПолучБилет: {
    descriptionKey: 'models.i-i-s-kyrs18-покупка-билета.validations.варПолучБилет.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  времяПокупки: {
    descriptionKey: 'models.i-i-s-kyrs18-покупка-билета.validations.времяПокупки.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  датаПокупки: {
    descriptionKey: 'models.i-i-s-kyrs18-покупка-билета.validations.датаПокупки.__caption__',
    validators: [
      validator('ds-error'),
      validator('date'),
    ],
  },
  билетКасса: {
    descriptionKey: 'models.i-i-s-kyrs18-покупка-билета.validations.билетКасса.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  покупатель: {
    descriptionKey: 'models.i-i-s-kyrs18-покупка-билета.validations.покупатель.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  информация: {
    descriptionKey: 'models.i-i-s-kyrs18-покупка-билета.validations.информация.__caption__',
    validators: [
      validator('ds-error'),
      validator('has-many'),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('ПокупкаБилетаE', 'i-i-s-kyrs18-покупка-билета', {
    датаПокупки: attr('Дата покупки', { index: 0 }),
    времяПокупки: attr('Время покупки', { index: 1 }),
    покупатель: belongsTo('i-i-s-kyrs18-покупатель', 'ФИО', {
      датРожд: attr('Дата рождения', { index: 3 }),
      серияПаспорта: attr('Серия паспорта', { index: 4 }),
      номерПаспорта: attr('Номер паспорта', { index: 5 }),
      банкСчет: attr('Банковский счет', { index: 6 }),
      элПочта: attr('Электронная почта', { index: 7 })
    }, { index: 2, displayMemberPath: 'фИО' }),
    варПолучБилет: attr('Вариант получения билета', { index: 8 }),
    информация: hasMany('i-i-s-kyrs18-информация', 'Информация', {
      датаПоезд: attr('Дата поездки', { index: 0 }),
      место: attr('Место', { index: 1 })
    })
  });

  modelClass.defineProjection('ПокупкаБилетаL', 'i-i-s-kyrs18-покупка-билета', {
    датаПокупки: attr('Дата покупки', { index: 0 }),
    времяПокупки: attr('Время покупки', { index: 1 }),
    покупатель: belongsTo('i-i-s-kyrs18-покупатель', 'ФИО', {
      датРожд: attr('Дата рождения', { index: 3 }),
      серияПаспорта: attr('Серия паспорта', { index: 4 }),
      номерПаспорта: attr('Номер паспорта', { index: 5 }),
      банкСчет: attr('Банковский счет', { index: 6 }),
      элПочта: attr('Электронная почта', { index: 7 })
    }, { index: 2, displayMemberPath: 'фИО' }),
    варПолучБилет: attr('Вариант получения билета', { index: 8 })
  });
};
