define(
    [
        'angular',
        'app.core'
    ],
    function (angular, core) {
        'use strict';

        var config = {
            appErrorPrefix: '[NG-Modular Error] ',
            appTitle: 'Task',
            version: '1.0.0'
        };

        return core.value('config', config);
    })