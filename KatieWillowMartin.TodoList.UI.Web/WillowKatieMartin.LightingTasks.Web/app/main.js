require.config({

    paths: {
        'domReady': '../Scripts/domReady',
        'angular': '../Scripts/angular',
        'angular-route': '../Scripts/angular-route',
        'app': '../app/app.module'
    },

    shim: {
        'angular': {
            'exports': 'angular'
        },
        'angular-route': {
            'deps': ['angular'],
            'exports': 'angular-route'
        }
    },

    deps: [
        './bootstrap'
    ]
});