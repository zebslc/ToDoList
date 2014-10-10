(function() {
    'use strict';

    var core = angular.module('app.core');

    var config = {
        appErrorPrefix: '[NG-Modular Error] ',
        appTitle: 'Tasks',
        version: '1.0.0'
    };

    core.value('config', config);
})();