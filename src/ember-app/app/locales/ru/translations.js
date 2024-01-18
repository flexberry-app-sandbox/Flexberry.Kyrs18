import $ from 'jquery';
import EmberFlexberryTranslations from 'ember-flexberry/locales/ru/translations';

import IISKyrs18БилетКассаLForm from './forms/i-i-s-kyrs18-билет-касса-l';
import IISKyrs18МаршрутLForm from './forms/i-i-s-kyrs18-маршрут-l';
import IISKyrs18ОбслуживаниеLForm from './forms/i-i-s-kyrs18-обслуживание-l';
import IISKyrs18ОператорLForm from './forms/i-i-s-kyrs18-оператор-l';
import IISKyrs18ПеревозчикLForm from './forms/i-i-s-kyrs18-перевозчик-l';
import IISKyrs18ПокупательLForm from './forms/i-i-s-kyrs18-покупатель-l';
import IISKyrs18ПокупкаБилетаLForm from './forms/i-i-s-kyrs18-покупка-билета-l';
import IISKyrs18БилетКассаEForm from './forms/i-i-s-kyrs18-билет-касса-e';
import IISKyrs18МаршрутEForm from './forms/i-i-s-kyrs18-маршрут-e';
import IISKyrs18ОбслуживаниеEForm from './forms/i-i-s-kyrs18-обслуживание-e';
import IISKyrs18ОператорEForm from './forms/i-i-s-kyrs18-оператор-e';
import IISKyrs18ПеревозчикEForm from './forms/i-i-s-kyrs18-перевозчик-e';
import IISKyrs18ПокупательEForm from './forms/i-i-s-kyrs18-покупатель-e';
import IISKyrs18ПокупкаБилетаEForm from './forms/i-i-s-kyrs18-покупка-билета-e';
import IISKyrs18БилетКассаModel from './models/i-i-s-kyrs18-билет-касса';
import IISKyrs18ИнформацияModel from './models/i-i-s-kyrs18-информация';
import IISKyrs18МаршрутModel from './models/i-i-s-kyrs18-маршрут';
import IISKyrs18ОбслуживаниеModel from './models/i-i-s-kyrs18-обслуживание';
import IISKyrs18ОператорModel from './models/i-i-s-kyrs18-оператор';
import IISKyrs18ПеревозчикModel from './models/i-i-s-kyrs18-перевозчик';
import IISKyrs18ПокупательModel from './models/i-i-s-kyrs18-покупатель';
import IISKyrs18ПокупкаБилетаModel from './models/i-i-s-kyrs18-покупка-билета';

const translations = {};
$.extend(true, translations, EmberFlexberryTranslations);

$.extend(true, translations, {
  models: {
    'i-i-s-kyrs18-билет-касса': IISKyrs18БилетКассаModel,
    'i-i-s-kyrs18-информация': IISKyrs18ИнформацияModel,
    'i-i-s-kyrs18-маршрут': IISKyrs18МаршрутModel,
    'i-i-s-kyrs18-обслуживание': IISKyrs18ОбслуживаниеModel,
    'i-i-s-kyrs18-оператор': IISKyrs18ОператорModel,
    'i-i-s-kyrs18-перевозчик': IISKyrs18ПеревозчикModel,
    'i-i-s-kyrs18-покупатель': IISKyrs18ПокупательModel,
    'i-i-s-kyrs18-покупка-билета': IISKyrs18ПокупкаБилетаModel
  },

  'application-name': 'Kyrs18',

  forms: {
    loading: {
      'spinner-caption': 'Данные загружаются, пожалуйста подождите...'
    },
    index: {
      greeting: 'Добро пожаловать на тестовый стенд ember-flexberry!'
    },

    application: {
      header: {
        menu: {
          'sitemap-button': {
            title: 'Меню'
          },
          'user-settings-service-checkbox': {
            caption: 'Использовать сервис сохранения пользовательских настроек'
          },
          'show-menu': {
            caption: 'Показать меню'
          },
          'hide-menu': {
            caption: 'Скрыть меню'
          },
          'language-dropdown': {
            caption: 'Язык приложения',
            placeholder: 'Выберите язык'
          }
        },
        login: {
          caption: 'Вход'
        },
        logout: {
          caption: 'Выход'
        }
      },

      footer: {
        'application-name': 'Kyrs18',
        'application-version': {
          caption: 'Версия аддона {{version}}',
          title: 'Это версия аддона ember-flexberry, которая сейчас используется в этом тестовом приложении ' +
          '(версия npm-пакета + хэш коммита). ' +
          'Кликните, чтобы перейти на GitHub.'
        }
      },

      sitemap: {
        'application-name': {
          caption: 'Kyrs18',
          title: 'Kyrs18'
        },
        'application-version': {
          caption: 'Версия аддона {{version}}',
          title: 'Это версия аддона ember-flexberry, которая сейчас используется в этом тестовом приложении ' +
          '(версия npm-пакета + хэш коммита). ' +
          'Кликните, чтобы перейти на GitHub.'
        },
        index: {
          caption: 'Главная',
          title: ''
        },
        kyrs18: {
          caption: 'Kyrs18',
          title: 'Kyrs18',
          'i-i-s-kyrs18-оператор-l': {
            caption: 'Оператор',
            title: ''
          },
          'i-i-s-kyrs18-маршрут-l': {
            caption: 'Маршрут',
            title: ''
          },
          'i-i-s-kyrs18-обслуживание-l': {
            caption: 'Обслуживание',
            title: ''
          },
          'i-i-s-kyrs18-покупатель-l': {
            caption: 'Покупатель',
            title: ''
          },
          'i-i-s-kyrs18-покупка-билета-l': {
            caption: 'Покупка билета',
            title: ''
          },
          'i-i-s-kyrs18-перевозчик-l': {
            caption: 'Перевозчик',
            title: ''
          },
          'i-i-s-kyrs18-билет-касса-l': {
            caption: 'Билетная касса',
            title: ''
          }
        }
      }
    },

    'edit-form': {
      'save-success-message-caption': 'Сохранение завершилось успешно',
      'save-success-message': 'Объект сохранен',
      'save-error-message-caption': 'Ошибка сохранения',
      'delete-success-message-caption': 'Удаление завершилось успешно',
      'delete-success-message': 'Объект удален',
      'delete-error-message-caption': 'Ошибка удаления'
    },
    'i-i-s-kyrs18-билет-касса-l': IISKyrs18БилетКассаLForm,
    'i-i-s-kyrs18-маршрут-l': IISKyrs18МаршрутLForm,
    'i-i-s-kyrs18-обслуживание-l': IISKyrs18ОбслуживаниеLForm,
    'i-i-s-kyrs18-оператор-l': IISKyrs18ОператорLForm,
    'i-i-s-kyrs18-перевозчик-l': IISKyrs18ПеревозчикLForm,
    'i-i-s-kyrs18-покупатель-l': IISKyrs18ПокупательLForm,
    'i-i-s-kyrs18-покупка-билета-l': IISKyrs18ПокупкаБилетаLForm,
    'i-i-s-kyrs18-билет-касса-e': IISKyrs18БилетКассаEForm,
    'i-i-s-kyrs18-маршрут-e': IISKyrs18МаршрутEForm,
    'i-i-s-kyrs18-обслуживание-e': IISKyrs18ОбслуживаниеEForm,
    'i-i-s-kyrs18-оператор-e': IISKyrs18ОператорEForm,
    'i-i-s-kyrs18-перевозчик-e': IISKyrs18ПеревозчикEForm,
    'i-i-s-kyrs18-покупатель-e': IISKyrs18ПокупательEForm,
    'i-i-s-kyrs18-покупка-билета-e': IISKyrs18ПокупкаБилетаEForm
  },

});

export default translations;
