var app = angular.module("myapp", []);
app.controller('usercontroller', function ($scope, $http)
{
    $scope.MarksList = new Array();
    
    

    $scope.user = {
        fname: "shubham",
        lname: "jasani",
        uname: "shubh",
        pass:"******"
    }
    $scope.Add = function () {
        var Master = {
            id:$scope.user.id,
            Fname: $scope.user.fname,
            Lname: $scope.user.lname,
            Username: $scope.user.uname,
            password: $scope.user.pass,
            MarksList: $scope.MarksList
        }
       
        $.ajax({
            url: "/UserMaster/Add/",
            type: "POST",
            data: Master ,
            success:function(response)
            {
                if (response.status == "Success") {
                    alert("Data Save SuccessFully");
                    location.reload(true);
                }
                else {
                    alert(response.error);
                }
            }

        })
    }


    $scope.getdata = function () {
        $.ajax({
            url: "/UserMaster/getdata/",
            type: "GET",
            data: {},
            success: function (response)
            {
                
                if (response.status == "Success")
                {
                    
                    var datamaster = response.data;
                    var parsemasterdata = JSON.parse(datamaster);
                    $scope.MasterDetails = parsemasterdata;
                    $scope.$apply();
                }
                else {
                    alert(response.error);
                }
            }
        })
    }
    $scope.delete = function (master) {
        var id = master;
        $.ajax({
            url: "/UserMaster/deleterecord/",
            type: "POST",
            data: { id: id },
            success:function(response)
            {
                if(response.status=="Success")
                {
                    alert("Delete Successfully");
                    $scope.getdata();

                }
                else {
                    alert("Not Delete");
                }
            }
        })
    }
    $scope.Filldata = function (id) {
        var ID = id;
       // alert(ID);
        $.ajax({
            url: "/UserMaster/getsinglerecord/",
            type: "GET",
            data: { ID: ID },
            success:function(response)
            {
                //alert("Success");
                if(response.status=="Success")
                {
                    $scope.master = response.data;
                    var parse = JSON.parse($scope.master);
                    
                    //$scope.user.id = parse[0].Id;
                    //alert($scope.user.id);
                    //$scope.user.fname = parse[0].Fname;
                    //alert($scope.user.fname)
                    //$scope.user.lname = parse[0].Lname;
                    //$scope.user.uname = parse[0].Username;
                    //$scope.user.pass = parse[0].Password;

                    $scope.user = {
                        id:parse[0].Id,
                        fname: parse[0].Fname,
                        lname: parse[0].Lname,
                        uname: parse[0].Username,
                        pass: parse[0].Password

                    }
                    $scope.$apply();
                }
                else {
                    alert("Something Is Wrong");
                }
            }
        })
    }

    $scope.AddMarks=function()
    {
        var obj = {
            Marks1: 0,
            Marks2: 0,
            Marks3: 0,
            Total: 0,
            Percentage: 0
        };
        $scope.MarksList.push(obj);
    }
    $scope.calculate = function (index, data) {
        $scope.MarksList[index].Total = parseInt(data.Marks1) + parseInt(data.Marks2) + parseInt(data.Marks3);
        $scope.MarksList[index].Percentage = parseFloat($scope.MarksList[index].Total / 3);
    }
       
});

//alert("Hello");