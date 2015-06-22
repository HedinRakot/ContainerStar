define([
	'base/base-object-add-view',
    'l!t!Settings/CustomersRelationships'
], function (BaseView , TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'Customers',
        actionUrl: '#Customers',

		bindings: function () {

            var self = this;
            var result = {
			'#number': 'number',
			'#name': 'name',
			'#street': 'street',
			'#zip': 'zip',
			'#city': 'city',
			'#country': 'country',
			'#phone': 'phone',
			'#mobile': 'mobile',
			'#fax': 'fax',
			'#email': 'email',
			'#comment': 'comment',
			'#iban': 'iban',
			'#bic': 'bic',
			'#withTaxes': 'withTaxes',
			'#autoDebitEntry': 'autoDebitEntry',
			'#autoBill': 'autoBill',
			'#discount': 'discount',
			'#ustId': 'ustId',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'number');
			this.disableInput(this, 'name');
			this.disableInput(this, 'street');
			this.disableInput(this, 'zip', 'numeric');
			this.disableInput(this, 'city');
			this.disableInput(this, 'country');
			this.disableInput(this, 'phone');
			this.disableInput(this, 'mobile');
			this.disableInput(this, 'fax');
			this.disableInput(this, 'email');
			this.disableInput(this, 'comment');
			this.disableInput(this, 'iban');
			this.disableInput(this, 'bic');
			this.disableInput(this, 'withTaxes');
			this.disableInput(this, 'autoDebitEntry');
			this.disableInput(this, 'autoBill');
			this.disableInput(this, 'discount', 'numeric');
			this.disableInput(this, 'ustId');

            return this;
        }
		,events: {
		}
    });

    return view;
});
