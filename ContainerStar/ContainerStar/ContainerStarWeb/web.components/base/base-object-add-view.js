﻿define(["base/base-edit-model-view"],function(e){"use strict";var t=function(e,t,a){void 0==a?e.$("#"+t).attr("disabled",!Application.canTableItemBeEdit(e.tableName,t)):"date"==a?e.$("#"+t).data("kendoDatePicker").enable(Application.canTableItemBeEdit(e.tableName,t)):"numeric"==a?e.$("#"+t).data("kendoNumericTextBox").enable(Application.canTableItemBeEdit(e.tableName,t)):"select"==a&&e.$("#"+t).data("kendoDropDownList").enable(Application.canTableItemBeEdit(e.tableName,t))},a=e.extend({tabView:null,containerSelector:".relations-container",tableName:null,successAction:null,cancelAction:null,renderWithoutBindings:function(){var e=this;return a.__super__.render.apply(e,arguments),Application.canTableItemBeEdit(e.tableName)||e.$(".save").remove(),Application.canTableItemBeDeleted(e.tableName)||e.$(".remove").remove(),e},render:function(){var e=this;a.__super__.render.apply(e,arguments),Application.canTableItemBeEdit(e.tableName)||e.$(".save").remove(),Application.canTableItemBeDeleted(e.tableName)||e.$(".remove").remove();var t={".relations-container":{observe:"id",visible:!0,updateView:!0,update:function(e,t){if(t){var a=this,n=new Backbone.Model({}),i=_.extend({},{model:n}),i=_.extend(i,a.options),l=new a.tabView(i);a.showView(l,a.containerSelector)}}},".remove":{observe:"id",visible:!0}};return e.stickit(e.model,t),e},success:function(){location.hash=this.actionUrl+"/"+this.model.id},cancel:function(){location.hash=this.actionUrl},disableInput:function(e,a,n){t(e,a,n)}});return a});