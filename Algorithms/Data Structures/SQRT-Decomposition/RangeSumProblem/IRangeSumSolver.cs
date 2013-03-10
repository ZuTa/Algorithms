﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeSumProblem
{
    public interface IRangeSumSolver
    {

        List<int> Solve(int[] array, List<Request> requests);

    }
}
