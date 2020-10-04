﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using froGH.Properties;
using Grasshopper.Kernel;
using Rhino.Geometry;

namespace froGH
{
    public class SaveStringToFile : GH_Component
    {
        /// <summary>
        /// Initializes a new instance of the SaveStringToFile class.
        /// </summary>
        public SaveStringToFile()
          : base("Save String To File", "f_Str2File",
              "Saves a text sequence to a file",
              "froGH", "File I-O")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddTextParameter("String", "S", "String to save (as List)", GH_ParamAccess.list);
            pManager.AddTextParameter("File Path", "P", "File absolute path", GH_ParamAccess.item);
            pManager.AddTextParameter("File Name", "F", "Filename and extension", GH_ParamAccess.item);
            pManager.AddBooleanParameter("Save trigger", "S", "Activate saving - attach a button and click to save", GH_ParamAccess.item, false);
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object is used to retrieve from inputs and store in outputs.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            List<string> S = new List<string>();
            if (!DA.GetDataList(0, S)) return;
            string dir = "";
            if (!DA.GetData(1, ref dir)) return;
            string file = "";
            if (!DA.GetData(2, ref file)) return;
            bool save = false;
            DA.GetData(3, ref save);

            if (!save) return;

            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

            String target = dir + file;

            System.IO.File.WriteAllLines(target, S.ToArray());
        }

        /// <summary>
        /// Exposure override for position in the SUbcategory (options primary to septenary)
        /// https://apidocs.co/apps/grasshopper/6.8.18210/T_Grasshopper_Kernel_GH_Exposure.htm
        /// </summary>
        public override GH_Exposure Exposure
        {
            get { return GH_Exposure.tertiary; }
        }

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                //You can add image files to your project resources and access them like this:
                // return Resources.IconForThisComponent;
                return Resources.String2File_GH;
            }
        }

        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid
        {
            get { return new Guid("954414d0-ae21-4efe-a776-c7637ac24f84"); }
        }
    }
}