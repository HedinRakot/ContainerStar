﻿define(["kendo/kendo.binder","kendo/kendo.editable","widgets/select-box"],function(){"use strict";var e=window.kendo,t=e.ui,i=t.Widget,n=(e.data.Binder,"change"),d=i.extend({init:function(e,t){var d=this;i.fn.init.call(d,e,t),d.options.textField=d.options.dataTextField=$(e).data("text-field"),d.options.valueField=d.options.dataValueField=$(e).data("value-field"),d.options.valuePrimitive=!0,$(e).change(function(){d.trigger(n)})},options:{name:"SelectBox"},value:function(e){return _.isUndefined(e)?$(this.element).selectBox("values"):(this.element.find("option").each(function(t,i){$(i).prop("selected",_.any(e,function(e){return $(i).val()==e}))}),void $(this.element).selectBox("restore"))},events:[n],dataBound:function(){$(this.element).selectBox()}});t.plugin(d);var a={source:e.data.binders.source.extend({init:function(t,i,n){e.data.binders.source.fn.init.call(this,t.element.get(0),i,n),this.widget=t},refresh:function(){e.data.binders.source.fn.refresh.apply(this,arguments),this.widget.dataBound()}}),value:e.data.binders.widget.multiselect.value};e.data.binders.widget.selectbox=a});