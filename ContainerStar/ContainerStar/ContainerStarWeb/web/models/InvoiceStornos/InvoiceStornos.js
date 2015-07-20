define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InvoiceStornos',
		fields: {
		    id: { type: "number", editable: false },
		    invoiceId: { type: "number", editable: false },
			price: { type: "number", editable: true, validation: { required: true }},
            proceedsAccount: { type: "number", editable: true, validation: { required: true } }
		},
	});
	return model;
});