define(
    'app.core',
    [
        'angular',
        'uiRouter',
        'ngResource'
    ]
    ,
    function (angular) {
        return angular.module('app.core', ['ui.router','ngResource']);
    });
