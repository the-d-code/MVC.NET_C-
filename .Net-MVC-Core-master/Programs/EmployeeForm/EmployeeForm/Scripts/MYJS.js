// Declare app level module which depends on filters, and services
var app = angular.module('myApp', []);

app.controller("RegisterCtrl", function ($scope, $location) {

    //$scope.Persnol = {
    //    Fname:""
    //}

    $scope.steps = [
      'Step 1: Persnol',
      'Step 2: Employement',
      'Step 3: Family',
      'Step 4: Education',
      'Step 5: Experiance',
      'Step 6: Login'
    ];
    $scope.selection = $scope.steps[0];

    $scope.getCurrentStepIndex = function () {
        // Get the index of the current step given selection
        return _.indexOf($scope.steps, $scope.selection);
    };

    // Go to a defined step index
    $scope.goToStep = function (index) {
        if (!_.isUndefined($scope.steps[index])) {
            $scope.selection = $scope.steps[index];
        }
    };

    $scope.hasNextStep = function () {
        var stepIndex = $scope.getCurrentStepIndex();
        var nextStep = stepIndex + 1;
        // Return true if there is a next step, false if not
        return !_.isUndefined($scope.steps[nextStep]);
    };

    $scope.hasPreviousStep = function () {
        var stepIndex = $scope.getCurrentStepIndex();
        var previousStep = stepIndex - 1;
        // Return true if there is a next step, false if not
        return !_.isUndefined($scope.steps[previousStep]);
    };

    $scope.incrementStep = function () {
        //alert("hi");

        if ($scope.hasNextStep()) {
            var stepIndex = $scope.getCurrentStepIndex();
          
           
            
          
            
           
            console.table(form2)
            //alert(stepIndex);
            //alert(form);
            //console.table(form)
            // var IsValid = $(form[stepIndex]).parsley().validate();
           
            if (stepIndex == 0) {
                var form1 = $('#employee-vertical1').find('form');
                var IsValid = $(form1[stepIndex]).parsley().validate();
                alert(IsValid)
                // alert(form1[stepIndex])
                //var name = $scope.Persnol.Fname;
                //alert(name);
                alert(stepIndex)
                if (IsValid) {
                    var nextStep = stepIndex + 1;
                    $scope.selection = $scope.steps[nextStep];
                    

                }

            }
            if (stepIndex == 1) {

                var form2 = $('#employee-vertical2').find('form');
                console.table(form2);
                alert(stepIndex)
                //var stepIndex = $scope.getCurrentStepIndex();
                var IsValid2 = $(form2).parsley().validate();
                alert(IsValid2)
                if (IsValid2) {

                    var nextStep = stepIndex + 1;
                    $scope.selection = $scope.steps[nextStep];
                   
                }
            }
            else if (stepIndex == 2) {
                var form3 = $('#employee-vertical3').find('form');
                var IsValid3 = $(form3).parsley().validate();
                if (IsValid3) {
                    var nextStep = stepIndex + 1;
                    $scope.selection = $scope.steps[nextStep];
                }
            }
            else if (stepIndex == 3) {
                var form4 = $('#employee-vertical4').find('form');
                var IsValid3 = $(form4).parsley().validate();
                if (IsValid3) {
                    var nextStep = stepIndex + 1;
                    $scope.selection = $scope.steps[nextStep];
                }
            }
            else if (stepIndex == 4) {
                var form5 = $('#employee-vertical5').find('form');
                var IsValid4 = $(form5).parsley().validate();
                if (IsValid4) {
                    var nextStep = stepIndex + 1;
                    $scope.selection = $scope.steps[nextStep];
                }
            }
            else if (stepIndex == 5) {
                var form6 = $('#employee-vertical6').find('form');
                var IsValid5 = $(form6).parsley().validate();
                if (IsValid5) {
                    var nextStep = stepIndex + 1;
                    $scope.selection = $scope.steps[nextStep];
                }
            }

            //if (stepIndex == 0)
            //{
            //    alert("HEllo");
            //}
            //VALIDATION
            //if (IsValid) {

            //    var nextStep = stepIndex + 1;
            //    $scope.selection = $scope.steps[nextStep];

            //}
        }
    };

    $scope.decrementStep = function () {
        if ($scope.hasPreviousStep()) {
            var stepIndex = $scope.getCurrentStepIndex();
            var previousStep = stepIndex - 1;
            $scope.selection = $scope.steps[previousStep];
        }
    };
})