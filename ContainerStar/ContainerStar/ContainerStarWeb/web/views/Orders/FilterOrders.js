define([
	'base/base-object-filter-view',
	'models/FilterOrders'
], function (BaseFilterView, Filter) {
    'use strict'

    var view = BaseFilterView.extend({

        filter: Filter,

        getFilters: function () {

            var result = [],
                fromDate = this.model.get('fromDate'),
                toDate = this.model.get('toDate'),
                isClosed = this.model.get('isClosed'),
                name = this.model.get('name'),
                status = 1;

            result.push({
                field: 'createDate',
                operator: 'gte',
                value: fromDate
            });

            result.push({
                field: 'createDate',
                operator: 'lte',
                value: toDate
            });

            if (isClosed)
            {
                status = 2
            }

            result.push({
                field: 'status',
                operator: 'eq',
                value: status
            });

            result.push({
                field: 'name',
                operator: 'contains',
                value: this.model.get('name')
            });

            return result;
        },

        bindings: function () {

            var self = this;

            var result = {

                '#fromDate': 'fromDate',
                '#toDate': 'toDate',
                '#name': 'name',
                '#isClosed': 'isClosed',                
            };

            return result;
        },
        
        render: function () {

            var self = this;

            view.__super__.renderWithoutBindings.apply(self, arguments);

            return self;
        }
    });

    return view;
});
