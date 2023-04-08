    function activities()
    {
        var shape = document.getElementById("shapeForm").value;

    // Hide all input fields by default
    var inputs = document.querySelectorAll(".form-control");
        for (var i = 0; i < inputs.length; i++)
        {
        inputs[i].style.display = "none";
        }

    // Show only the input fields relevant to the selected shape
        if (shape === "Rectangle")
        {
            document.getElementById("RectangleHeight").style.display = "block";
            document.getElementById("RectangleLength").style.display = "block";
        }
        else if (shape === "Circle")
        {
            document.getElementById("CircleRadius").style.display = "block";
        }
        else
        {
            document.getElementById("SquareLength").style.display = "block";
        }
    }

    


