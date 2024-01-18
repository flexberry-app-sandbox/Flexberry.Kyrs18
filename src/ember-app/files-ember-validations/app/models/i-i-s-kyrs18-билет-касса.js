import {
  defineNamespace,
  defineProjections,
  Model as БилетКассаMixin
} from '../mixins/regenerated/models/i-i-s-kyrs18-билет-касса';

import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

let Model = EmberFlexberryDataModel.extend(БилетКассаMixin, {
});

defineNamespace(Model);
defineProjections(Model);

export default Model;
