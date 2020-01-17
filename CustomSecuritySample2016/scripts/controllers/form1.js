define(['app'], function (app) {
    app.controller('form', function ($scope) {
    	console.log('hello formController');
    	$scope.msg = "hello formController";
    });
}); 
