define('app',
    [
        'angular',
        'angular-route',
         './core/core.module',
        './tasks/tasks.module',
        './core/register',
        './tasks/register'
    ],
    function (angular) {
    'use strict';
       return angular.module('app',
        [
            'ngRoute',
            'app.core',
            'app.tasks'
        ]);
    });