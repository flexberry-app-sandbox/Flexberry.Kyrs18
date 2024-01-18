import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  времяПроверки: DS.attr('string'),
  готовКРаботе: DS.attr('boolean'),
  чекЛента: DS.attr('boolean'),
  билетКасса: DS.belongsTo('i-i-s-kyrs18-билет-касса', { inverse: null, async: false }),
  оператор: DS.belongsTo('i-i-s-kyrs18-оператор', { inverse: null, async: false })
});

export let ValidationRules = {
  времяПроверки: {
    descriptionKey: 'models.i-i-s-kyrs18-обслуживание.validations.времяПроверки.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  готовКРаботе: {
    descriptionKey: 'models.i-i-s-kyrs18-обслуживание.validations.готовКРаботе.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  чекЛента: {
    descriptionKey: 'models.i-i-s-kyrs18-обслуживание.validations.чекЛента.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  билетКасса: {
    descriptionKey: 'models.i-i-s-kyrs18-обслуживание.validations.билетКасса.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  оператор: {
    descriptionKey: 'models.i-i-s-kyrs18-обслуживание.validations.оператор.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('ОбслуживаниеE', 'i-i-s-kyrs18-обслуживание', {
    билетКасса: belongsTo('i-i-s-kyrs18-билет-касса', 'Наименование', {
      адрес: attr('Адрес', { index: 2 })
    }, { index: 1, displayMemberPath: 'наименование' }),
    времяПроверки: attr('Время проверки', { index: 3 }),
    чекЛента: attr('Чек лента', { index: 4 }),
    готовКРаботе: attr('Готов к работе', { index: 5 }),
    оператор: belongsTo('i-i-s-kyrs18-оператор', 'Оператор', {

    }, { index: 0, displayMemberPath: 'фИО' })
  });

  modelClass.defineProjection('ОбслуживаниеL', 'i-i-s-kyrs18-обслуживание', {
    билетКасса: belongsTo('i-i-s-kyrs18-билет-касса', 'Наименование', {
      адрес: attr('Адрес', { index: 2 })
    }, { index: 1, displayMemberPath: 'наименование' }),
    времяПроверки: attr('Время проверки', { index: 3 }),
    чекЛента: attr('Чек лента', { index: 4 }),
    готовКРаботе: attr('Готов к работе', { index: 5 }),
    оператор: belongsTo('i-i-s-kyrs18-оператор', 'ФИО', {

    }, { index: 0, displayMemberPath: 'наименование' })
  });
};
