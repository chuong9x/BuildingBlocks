using Elements;
using Elements.Geometry;
using System;
using System.Linq;
using System.Collections.Generic;
using GeometryEx;

namespace CoreByLevels
{
    public static class CoreByLevels
    {
        /// <summary>
        /// The CoreByLevels function.
        /// </summary>
        /// <param name="model">The input model.</param>
        /// <param name="input">The arguments to the execution.</param>
        /// <returns>A CoreByLevelsOutputs instance containing computed results and the model with any new elements.</returns>
        public static CoreByLevelsOutputs Execute(Dictionary<string, Model> inputModels, CoreByLevelsInputs input)
        {
            var levels = new List<LevelPerimeter>();
            inputModels.TryGetValue("Levels", out var model);
            if (model == null || model.AllElementsOfType<LevelPerimeter>().Count() == 0)
            {
                throw new ArgumentException("No LevelPerimeters found.");
            }
            levels.AddRange(model.AllElementsOfType<LevelPerimeter>());
            var coreMaker = new CoreMaker(levels, input.Setback, input.Rotation);
            var output = new CoreByLevelsOutputs(coreMaker.Restrooms.Count(), coreMaker.LiftQuantity);

            output.model.AddElement(new Exclusion(coreMaker.Perimeter, coreMaker.Elevation, Guid.NewGuid(), "Core Exclusion"));
            foreach (var room in coreMaker.Restrooms)
            {
                output.model.AddElement(room);
            }
            foreach (var mech in coreMaker.Mechanicals)
            {
                output.model.AddElement(mech);
            }
            foreach (var stair in coreMaker.Stairs)
            {
                output.model.AddElement(stair);
            }
            foreach (var lift in coreMaker.Lifts)
            {
                output.model.AddElement(lift);
            }
            return output;
        }
    }
}