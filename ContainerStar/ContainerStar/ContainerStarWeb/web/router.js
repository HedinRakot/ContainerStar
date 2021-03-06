﻿define([
    'base-router',
    'router-masterdata'
], function (BaseRouter, MasterDataRouter) {
	'use strict';

	var router = Backbone.Router.extend({
		initialize: function (options) {
			var self = this;
			this.masterView = options.masterView;
			this.listenTo(Backbone, 'logged-in', function () {

				location.reload();
			});
			this.listenTo(Backbone, 'logged-out', function () {
				location.reload();
			});
			this.listenTo(Backbone, 'forbidden', function () {
			    BaseRouter.showView.call(self, self, 'l!t!errors/forbidden');
			});
		},

		routes: function() {
		    
		    var commonRoutes =
            {
                'Home': _.partial(BaseRouter.showView, this, 'l!t!home/home', { ContainerTypesForDisposition: true, Equipments: true }, { searchFreeContainer: false }),
                'FreeContainers': _.partial(BaseRouter.showView, this, 'l!t!home/home', { ContainerTypesForDisposition: true, Equipments: true }, { searchFreeContainer: true }),
                'Settings': _.partial(BaseRouter.showView, this, 'l!t!Settings/Settings'),
                'Offers': _.partial(BaseRouter.showView, this, 'l!t!Orders/Offers', { ContainerTypes: true, Equipments: true, PaymentTypes: true }, { isOffer: true }),
                'Offers/create': _.partial(BaseRouter.showViewWithModel, this, 'l!t!Orders/AddOrders', 'models/Orders', { ContainerTypes: true, CommunicationPartners: true, Equipments: true }, { isOffer: true }),
                'Offers/:id': _.partial(BaseRouter.showViewWithModel, this, 'l!t!Orders/AddOrders', 'models/Orders', { ContainerTypes: true, CommunicationPartners: true, Equipments: true }, { isOffer: true }),
                'Orders': _.partial(BaseRouter.showView, this, 'l!t!Orders/Orders', { ContainerTypes: true, Equipments: true, PaymentTypes: true }, { isOffer: false }),
                'Orders/create': _.partial(BaseRouter.showViewWithModel, this, 'l!t!Orders/AddOrders', 'models/Orders', { ContainerTypes: true, CommunicationPartners: true, Equipments: true, PaymentTypes: true }, { isOffer: false }),
                'Orders/:id': _.partial(BaseRouter.showViewWithModel, this, 'l!t!Orders/AddOrders', 'models/Orders', { ContainerTypes: true, CommunicationPartners: true, Equipments: true, PaymentTypes: true }, { isOffer: false }),
                'Invoices': _.partial(BaseRouter.showView, this, 'l!t!Invoices/Invoices', { PaymentTypes: true }, false),
                'Invoices/:id': _.partial(BaseRouter.showViewWithModel, this, 'l!t!Invoices/AddInvoices', 'models/Invoices/Invoices', { PaymentIntervals: true, PaymentTypes: true }, false),
                'InvoiceStornos': _.partial(BaseRouter.showView, this, 'l!t!InvoiceStornos/Invoices', { ProceedsAccounts: true }, false),
                'TransportOrders': _.partial(BaseRouter.showView, this, 'l!t!TransportOrders/TransportOrders', { TransportProducts: true }, { isOffer: false }),
                'TransportOrders/create': _.partial(BaseRouter.showViewWithModel, this, 'l!t!TransportOrders/AddTransportOrders', 'models/TransportOrders/TransportOrders', { CommunicationPartners: true, TransportProducts: true }, { isOffer: false }),
                'TransportOrders/:id': _.partial(BaseRouter.showViewWithModel, this, 'l!t!TransportOrders/AddTransportOrders', 'models/TransportOrders/TransportOrders', { CommunicationPartners: true, TransportProducts: true }, { isOffer: false }),
            };
		    
		    var result = $.extend({}, commonRoutes, MasterDataRouter.getAllMasterDataRoutes(this));

		    return result;
		}		
	});

	return router;
});