define(
    [
        'angular',
        'app.core',
        'ngResource'
    ],
    function (angular, core) {
        'use strict';

        var config = {
            appErrorPrefix: '[NG-Modular Error] ',
            appTitle: 'CustomTask',
            version: '1.0.0'
        };

        core.config(function($resourceProvider) {
            $resourceProvider.defaults.stripTrailingSlashes = false;
        });

        return core.value('config', config);
    })