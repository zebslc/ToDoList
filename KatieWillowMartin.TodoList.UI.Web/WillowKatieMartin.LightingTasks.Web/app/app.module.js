define('app',
    [
        'angular',
        'uiRouter',
        './core/core.module',
        './tasks/tasks.module',
        './core/register',
        './tasks/register',
        './home/register'
    ],
    function (angular) {
        'use strict';
        return angular.module('app',
            [
                'app.core',
                'app.tasks',
                'ui.router'
            ]);
    });