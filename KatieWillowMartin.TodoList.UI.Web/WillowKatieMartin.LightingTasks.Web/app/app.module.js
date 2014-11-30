define('app',
    [
        'angular',
        'uiRouter',
        './core/core.module',
        './tasks/tasks.module',
        './core/register',
        './tasks/register'
    ],
    function (angular,router) {
        'use strict';
        return angular.module('app',
            [
                'app.core',
                'app.tasks',
                'ui.router'
            ]);
    });