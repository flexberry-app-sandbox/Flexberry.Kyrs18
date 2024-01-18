import { moduleForModel, test } from 'ember-qunit';

moduleForModel('i-i-s-kyrs18-перевозчик', 'Unit | Model | i-i-s-kyrs18-перевозчик', {
  // Specify the other units that are required for this test.
  needs: [
    'model:i-i-s-kyrs18-билет-касса',
    'model:i-i-s-kyrs18-информация',
    'model:i-i-s-kyrs18-маршрут',
    'model:i-i-s-kyrs18-обслуживание',
    'model:i-i-s-kyrs18-оператор',
    'model:i-i-s-kyrs18-перевозчик',
    'model:i-i-s-kyrs18-покупатель',
    'model:i-i-s-kyrs18-покупка-билета',
    'validator:ds-error',
    'validator:presence',
    'validator:number',
    'validator:date',
    'validator:belongs-to',
    'validator:has-many',
    'service:syncer',
  ],
});

test('it exists', function(assert) {
  let model = this.subject();

  // let store = this.store();
  assert.ok(!!model);
});
