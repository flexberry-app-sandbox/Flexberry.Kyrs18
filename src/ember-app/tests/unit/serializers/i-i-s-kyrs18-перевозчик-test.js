import { moduleForModel, test } from 'ember-qunit';

moduleForModel('i-i-s-kyrs18-перевозчик', 'Unit | Serializer | i-i-s-kyrs18-перевозчик', {
  // Specify the other units that are required for this test.
  needs: [
    'serializer:i-i-s-kyrs18-перевозчик',
    'service:syncer',
    'transform:file',
    'transform:decimal',
    'transform:guid',

    'transform:i-i-s-kyrs18-вариант',

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
  ],
});

// Replace this with your real tests.
test('it serializes records', function(assert) {
  let record = this.subject();

  let serializedRecord = record.serialize();

  assert.ok(serializedRecord);
});
