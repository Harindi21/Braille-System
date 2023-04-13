function showHideFields() {

    var shape = document.getElementById("myDropDownList1").value;

    if (shape == "Circle") {
        document.getElementById("CircleDiv").style.display = "block";
        document.getElementById("EnterDiv").style.display = "block";
        document.getElementById("SquareDiv").style.display = "none";
        document.getElementById("RectangleDiv").style.display = "none";
        document.getElementById("TriangleDiv").style.display = "none";
        document.getElementById("PentagonDiv").style.display = "none";
        document.getElementById("HexagonDiv").style.display = "none";
        document.getElementById("HeptagonDiv").style.display = "none";
        document.getElementById("OctagonDiv").style.display = "none";
        document.getElementById("NonagonDiv").style.display = "none";
        document.getElementById("ParallelogramDiv").style.display = "none";
        document.getElementById("TrapezoidDiv").style.display = "none";
        document.getElementById("RhombusDiv").style.display = "none";
        document.getElementById("QuadrilateralDiv").style.display = "none";

    }
    else if (shape == "Square") {
        document.getElementById("CircleDiv").style.display = "none";
        document.getElementById("SquareDiv").style.display = "block";
        document.getElementById("EnterDiv").style.display = "block";
        document.getElementById("RectangleDiv").style.display = "none";
        document.getElementById("TriangleDiv").style.display = "none";
        document.getElementById("PentagonDiv").style.display = "none";
        document.getElementById("HexagonDiv").style.display = "none";
        document.getElementById("HeptagonDiv").style.display = "none";
        document.getElementById("OctagonDiv").style.display = "none";
        document.getElementById("NonagonDiv").style.display = "none";
        document.getElementById("ParallelogramDiv").style.display = "none";
        document.getElementById("TrapezoidDiv").style.display = "none";
        document.getElementById("RhombusDiv").style.display = "none";
        document.getElementById("QuadrilateralDiv").style.display = "none";

    }
    else if (shape == "Rectangle") {
        document.getElementById("RectangleDiv").style.display = "block";
        document.getElementById("EnterDiv").style.display = "block";
        document.getElementById("SquareDiv").style.display = "none";
        document.getElementById("TriangleDiv").style.display = "none";
        document.getElementById("CircleDiv").style.display = "none";
        document.getElementById("PentagonDiv").style.display = "none";
        document.getElementById("HexagonDiv").style.display = "none";
        document.getElementById("HeptagonDiv").style.display = "none";
        document.getElementById("OctagonDiv").style.display = "none";
        document.getElementById("NonagonDiv").style.display = "none";
        document.getElementById("ParallelogramDiv").style.display = "none";
        document.getElementById("TrapezoidDiv").style.display = "none";
        document.getElementById("RhombusDiv").style.display = "none";
        document.getElementById("QuadrilateralDiv").style.display = "none";

    }
    else if (shape == "Triangle") {
        document.getElementById("TriangleDiv").style.display = "block";
        document.getElementById("EnterDiv").style.display = "block";
        document.getElementById("SquareDiv").style.display = "none";
        document.getElementById("RectangleDiv").style.display = "none";
        document.getElementById("CircleDiv").style.display = "none";
        document.getElementById("PentagonDiv").style.display = "none";
        document.getElementById("HexagonDiv").style.display = "none";
        document.getElementById("HeptagonDiv").style.display = "none";
        document.getElementById("OctagonDiv").style.display = "none";
        document.getElementById("NonagonDiv").style.display = "none";
        document.getElementById("ParallelogramDiv").style.display = "none";
        document.getElementById("TrapezoidDiv").style.display = "none";
        document.getElementById("RhombusDiv").style.display = "none";
        document.getElementById("QuadrilateralDiv").style.display = "none";

    }
    else if (shape == "Pentagon") {
        document.getElementById("CircleDiv").style.display = "none";
        document.getElementById("SquareDiv").style.display = "none";
        document.getElementById("EnterDiv").style.display = "block";
        document.getElementById("RectangleDiv").style.display = "none";
        document.getElementById("TriangleDiv").style.display = "none";
        document.getElementById("PentagonDiv").style.display = "block";
        document.getElementById("HexagonDiv").style.display = "none";
        document.getElementById("HeptagonDiv").style.display = "none";
        document.getElementById("OctagonDiv").style.display = "none";
        document.getElementById("NonagonDiv").style.display = "none";
        document.getElementById("ParallelogramDiv").style.display = "none";
        document.getElementById("TrapezoidDiv").style.display = "none";
        document.getElementById("RhombusDiv").style.display = "none";
        document.getElementById("QuadrilateralDiv").style.display = "none";

    }
    else if (shape == "Hexagon") {
        document.getElementById("RectangleDiv").style.display = "none";
        document.getElementById("EnterDiv").style.display = "block";
        document.getElementById("SquareDiv").style.display = "none";
        document.getElementById("TriangleDiv").style.display = "none";
        document.getElementById("CircleDiv").style.display = "none";
        document.getElementById("PentagonDiv").style.display = "none";
        document.getElementById("HexagonDiv").style.display = "block";
        document.getElementById("HeptagonDiv").style.display = "none";
        document.getElementById("OctagonDiv").style.display = "none";
        document.getElementById("NonagonDiv").style.display = "none";
        document.getElementById("ParallelogramDiv").style.display = "none";
        document.getElementById("TrapezoidDiv").style.display = "none";
        document.getElementById("RhombusDiv").style.display = "none";
        document.getElementById("QuadrilateralDiv").style.display = "none";

    }
    else if (shape == "Heptagon") {
        document.getElementById("TriangleDiv").style.display = "none";
        document.getElementById("EnterDiv").style.display = "block";
        document.getElementById("SquareDiv").style.display = "none";
        document.getElementById("RectangleDiv").style.display = "none";
        document.getElementById("CircleDiv").style.display = "none";
        document.getElementById("PentagonDiv").style.display = "none";
        document.getElementById("HexagonDiv").style.display = "none";
        document.getElementById("HeptagonDiv").style.display = "block";
        document.getElementById("OctagonDiv").style.display = "none";
        document.getElementById("NonagonDiv").style.display = "none";
        document.getElementById("ParallelogramDiv").style.display = "none";
        document.getElementById("TrapezoidDiv").style.display = "none";
        document.getElementById("RhombusDiv").style.display = "none";
        document.getElementById("QuadrilateralDiv").style.display = "none";

    }
    else if (shape == "Octagon") {
        document.getElementById("CircleDiv").style.display = "none";
        document.getElementById("SquareDiv").style.display = "none";
        document.getElementById("EnterDiv").style.display = "block";
        document.getElementById("RectangleDiv").style.display = "none";
        document.getElementById("TriangleDiv").style.display = "none";
        document.getElementById("PentagonDiv").style.display = "none";
        document.getElementById("HexagonDiv").style.display = "none";
        document.getElementById("HeptagonDiv").style.display = "none";
        document.getElementById("OctagonDiv").style.display = "block";
        document.getElementById("NonagonDiv").style.display = "none";
        document.getElementById("ParallelogramDiv").style.display = "none";
        document.getElementById("TrapezoidDiv").style.display = "none";
        document.getElementById("RhombusDiv").style.display = "none";
        document.getElementById("QuadrilateralDiv").style.display = "none";

    }
    else if (shape == "Nonagon") {
        document.getElementById("RectangleDiv").style.display = "none";
        document.getElementById("EnterDiv").style.display = "block";
        document.getElementById("SquareDiv").style.display = "none";
        document.getElementById("TriangleDiv").style.display = "none";
        document.getElementById("CircleDiv").style.display = "none";
        document.getElementById("PentagonDiv").style.display = "none";
        document.getElementById("HexagonDiv").style.display = "none";
        document.getElementById("HeptagonDiv").style.display = "none";
        document.getElementById("OctagonDiv").style.display = "none";
        document.getElementById("NonagonDiv").style.display = "block";
        document.getElementById("ParallelogramDiv").style.display = "none";
        document.getElementById("TrapezoidDiv").style.display = "none";
        document.getElementById("RhombusDiv").style.display = "none";
        document.getElementById("QuadrilateralDiv").style.display = "none";

    }
    else if (shape == "Parallelogram") {
        document.getElementById("CircleDiv").style.display = "none";
        document.getElementById("SquareDiv").style.display = "none";
        document.getElementById("EnterDiv").style.display = "block";
        document.getElementById("RectangleDiv").style.display = "none";
        document.getElementById("TriangleDiv").style.display = "none";
        document.getElementById("PentagonDiv").style.display = "none";
        document.getElementById("HexagonDiv").style.display = "none";
        document.getElementById("HeptagonDiv").style.display = "none";
        document.getElementById("OctagonDiv").style.display = "none";
        document.getElementById("NonagonDiv").style.display = "none";
        document.getElementById("ParallelogramDiv").style.display = "block";
        document.getElementById("TrapezoidDiv").style.display = "none";
        document.getElementById("RhombusDiv").style.display = "none";
        document.getElementById("QuadrilateralDiv").style.display = "none";

    }
    else if (shape == "Trapezoid") {
        document.getElementById("CircleDiv").style.display = "none";
        document.getElementById("SquareDiv").style.display = "none";
        document.getElementById("EnterDiv").style.display = "block";
        document.getElementById("RectangleDiv").style.display = "none";
        document.getElementById("TriangleDiv").style.display = "none";
        document.getElementById("PentagonDiv").style.display = "none";
        document.getElementById("HexagonDiv").style.display = "none";
        document.getElementById("HeptagonDiv").style.display = "none";
        document.getElementById("OctagonDiv").style.display = "none";
        document.getElementById("NonagonDiv").style.display = "none";
        document.getElementById("ParallelogramDiv").style.display = "none";
        document.getElementById("TrapezoidDiv").style.display = "block";
        document.getElementById("RhombusDiv").style.display = "none";
        document.getElementById("QuadrilateralDiv").style.display = "none";

    }
    else if (shape == "Rhombus") {
        document.getElementById("CircleDiv").style.display = "none";
        document.getElementById("SquareDiv").style.display = "none";
        document.getElementById("EnterDiv").style.display = "block";
        document.getElementById("RectangleDiv").style.display = "none";
        document.getElementById("TriangleDiv").style.display = "none";
        document.getElementById("PentagonDiv").style.display = "none";
        document.getElementById("HexagonDiv").style.display = "none";
        document.getElementById("HeptagonDiv").style.display = "none";
        document.getElementById("OctagonDiv").style.display = "none";
        document.getElementById("NonagonDiv").style.display = "none";
        document.getElementById("ParallelogramDiv").style.display = "none";
        document.getElementById("TrapezoidDiv").style.display = "none";
        document.getElementById("RhombusDiv").style.display = "block";
        document.getElementById("QuadrilateralDiv").style.display = "none";

    }
    else if (shape == "Quadrilateral") {
        document.getElementById("CircleDiv").style.display = "none";
        document.getElementById("SquareDiv").style.display = "none";
        document.getElementById("EnterDiv").style.display = "block";
        document.getElementById("RectangleDiv").style.display = "none";
        document.getElementById("TriangleDiv").style.display = "none";
        document.getElementById("PentagonDiv").style.display = "none";
        document.getElementById("HexagonDiv").style.display = "none";
        document.getElementById("HeptagonDiv").style.display = "none";
        document.getElementById("OctagonDiv").style.display = "none";
        document.getElementById("NonagonDiv").style.display = "none";
        document.getElementById("ParallelogramDiv").style.display = "none";
        document.getElementById("TrapezoidDiv").style.display = "none";
        document.getElementById("RhombusDiv").style.display = "none";
        document.getElementById("QuadrilateralDiv").style.display = "block";

    }

}

    


