angular.module('DiceApp', [])
.controller('DiceController', function ($scope, $http, $location, $window) {
    $scope.diceModel = {};
    $scope.message = '';
    $scope.result = "color-default";
    $scope.isViewLoading = false;
    $scope.ListDice = null;

    //default the dice sides to 6 sided
    $scope.maxValue = 6;
    //roll the initial dice
    getDiceRoll();
   
    $scope.errorMessage = null;
    $scope.getTotal = function () {
        var total = 0;
        if ($scope.ListDice != null)
        {
            $scope.ListDice.forEach(function (dice)
            {
                total += dice.CurrentRollValue;
            });

        }
        return total;
    }


    $scope.rollDice = getDiceRoll;
    //******=========Get All Dice=========******
    function getDiceRoll() {
        if ($scope.maxValue == null) {
            $scope.errorMessage = 'Required';
            return;
        }

        if ($scope.maxValue != null) {
            var value = parseInt($scope.maxValue);

            if (isNaN(value)) {
                $scope.errorMessage = 'Invalid input';
                return;
            }

            if (value < 6 || value > 20) {
                $scope.errorMessage = 'Invalid range. 6-20';
                return;
            }
            $scope.errorMessage = null;
        }

        debugger;
        $http.get('/Dice/RollDice?max='+$scope.maxValue)
            .then(function (response) {
                $scope.ListDice = response.data;
                
            })
            .catch(function (response) {
                $scope.message = 'Unexpected Error while loading data!!';
                $scope.result = "color-red";
                console.log($scope.message);
            });
    };


})
.config(function ($locationProvider) {
    $locationProvider.html5Mode(false);
});