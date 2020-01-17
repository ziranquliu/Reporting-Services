define([], function () {
    var basepath="./scripts/";
    var r = {
        defaultRoute: '/home',
        routes: {
            'home': {
                templateUrl: basepath+'views/home.html',
                url: '/home',
                dependencies: [basepath+'controllers/home.js'],
                allowAnonymous: true
            },
            'form': {
                templateUrl: basepath+'views/form.html',
                url: '/form',
                dependencies: [basepath+'controllers/form.js'],
                allowAnonymous: true
            },
            'form.required': {
                templateUrl: basepath+'views/form-required.html',
                url: '/required',
                dependencies: [],
                allowAnonymous: true
            },
            'form.optional': {
                templateUrl: basepath+'views/form-optional.html',
                url: '/optional',
                dependencies: [],
                allowAnonymous: true
            }, 
            'form.confirm': {
                templateUrl: basepath+'views/form-confirm.html',
                url: '/confirm',
                dependencies: [],
                allowAnonymous: true
            },
            'login':{
            	 templateUrl: basepath+'views/login.html',
                 url: '/login',
                 dependencies: [basepath+'controllers/login.js'],
                 allowAnonymous: true
            }
        }
    };
    return r;
});