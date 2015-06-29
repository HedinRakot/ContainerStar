﻿define([
    'l!t!Orders/Positions'
], function (BaseView) {
    'use strict';
    
    var view = BaseView.extend({

        isSellOrder: false,

        render: function () {

            var self = this;

            view.__super__.render.apply(self, arguments);           

            return self;
        },
        
    });

    return view;
});
