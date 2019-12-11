function student() { this.baseUrl = document.getElementById("baseURL").value; };
student.prototype.getAll = function () {
    var self = this;
    $.ajax({
        url: self.baseUrl + "api/student",
        type: "GET",
        headers: { 'Authorization': 'Basic ' + btoa('admin:admin') },
        contentType: "application/json; charset=utf-8",
        success: function (res) {
            console.log(res);
            if (res != null) {
                var strHTML = "<table class=\"table\"><tr><td>Id</td><td>Name</td><td>Age</td><td></td></tr>";
                for (var i = 0; i < res.length; i++) {
                    strHTML = strHTML + "<tr>" +
                                            "<td>" + res[i].Id + "</td>" +
                                            "<td>" + res[i].Name + "</td>" +
                                            "<td>" + res[i].Age + "</td>" +
                                            "<td><input type=\"button\" value=\"view\" class=\"view\" data-id=\"" + res[i].Id + "\"></td>" +
                                         "</tr>";
                }
                strHTML = strHTML + "</table>";
                $("#grid").html(strHTML);
            }
        },
        failure: function (response) {
            console.log("error" + response.responseText);
        },
        error: function (response) {
            console.log("error" + response.responseText);
        }
    });
};
student.prototype.getById = function (id) {

    var self = this;
    $.ajax({
        url: self.baseUrl + "api/student/" + id,
        type: "GET",
        headers: { 'Authorization': 'Basic ' + btoa('admin:admin') },
        contentType: "application/json; charset=utf-8",
        success: function (res) {
            console.log(res);
            if (res != null) {
                document.getElementById("Age").innerText = res.Age;
                document.getElementById("Course").innerText = res.Course;
                document.getElementById("CreatedDate").innerText = res.CreatedDate;
                document.getElementById("EnrollDate").innerText = res.EnrollDate;
                document.getElementById("Id").innerText = res.Id;
                document.getElementById("Marks").innerText = res.Marks;
                document.getElementById("ModifiedDate").innerText = res.ModifiedDate;
                document.getElementById("Name").innerText = res.Name;
                document.getElementById("Course").innerText = res.Course;
            }
        },
        failure: function (response) {
            console.log("error" + response.responseText);
        },
        error: function (response) {
            console.log("error" + response.responseText);
        }
    });

};