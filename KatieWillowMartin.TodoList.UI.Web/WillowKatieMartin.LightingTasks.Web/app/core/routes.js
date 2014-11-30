define(
    [
        'app.core',
        'angular',
        'uiRouter'
    ],

    function (module) {
        'use strict';

        return module.config([
            '$stateProvider',
            function ($stateProvider) {

                $stateProvider.state('list', {
                    url: '/list',
                    templateUrl: '/app/tasks/task-list.html',
                    controller: 'tasks'
                })

                .state('home', {
                    url: '/home',
                    templateUrl:'/app/home/home.html'
                    })
                ;

            }]);
    });
