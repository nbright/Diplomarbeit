﻿namespace TessellationDemo
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Windows.Data;
    using System.Windows.Media.Animation;
    using HelixToolkit;
    using HelixToolkit.SharpDX;
    using HelixToolkit.SharpDX.Wpf;
    using SharpDX;
    using Media3D = System.Windows.Media.Media3D;
    using Point3D = System.Windows.Media.Media3D.Point3D;
    using Vector3D = System.Windows.Media.Media3D.Vector3D;
    using System.IO;
    using SharpDX.D3DCompiler;
    using System.Windows.Media.Imaging;


    public class MainViewModel : BaseViewModel
    {
        public Geometry3D DefaultModel { get; private set; }
        public Geometry3D Lines { get; private set; }
        public Geometry3D Grid { get; private set; }

        public PhongMaterial DefaultMaterial { get; private set; }
        public SharpDX.Color GridColor { get; private set; }

        public Media3D.Transform3D DefaultTransform { get; private set; }
        public Media3D.Transform3D GridTransform { get; private set; }

        public Vector3 DirectionalLightDirection1 { get; private set; }
        public Vector3 DirectionalLightDirection2 { get; private set; }
        public Color4 DirectionalLightColor { get; private set; }
        public Color4 AmbientLightColor { get; private set; }
        
        public string[] MeshTopologyList { get; set; }
        
        private string meshTopology = MeshFaces.Default.ToString();
        public string MeshTopology
        {
            get { return this.meshTopology; }
            set
            {
                this.meshTopology = value;
                this.RenderTechnique = this.meshTopology == "Quads" ? Techniques.RenderPNQuads : Techniques.RenderPNTriangs;
                this.LoadModel(@"./Media/teapot_low_tex_quads.obj", this.meshTopology == "Quads" ? MeshFaces.QuadPatches : MeshFaces.Default);                                               
            }
        }

  
        public MainViewModel()
        {
            // titles
            this.Title = "Tessellation Demo";
            this.SubTitle = "ARTR 2013 - Assignment #1";
            
            // camera setup
            this.Camera = new PerspectiveCamera { Position = new Point3D(7, 10, 12), LookDirection = new Vector3D(-7, -10, -12), UpDirection = new Vector3D(0, 1, 0) };
            
            // register custom effect            
            this.RenderTechnique = Techniques.RenderPNQuads;

            // setup lighting            
            this.AmbientLightColor = new Color4(0.2f, 0.2f, 0.2f, 1.0f);
            this.DirectionalLightColor = Color.White;
            this.DirectionalLightDirection1 = new Vector3(-0, -50, -20);
            this.DirectionalLightDirection2 = new Vector3(-0, -1 , +50);

            // model trafo
            this.DefaultTransform = new Media3D.TranslateTransform3D(0, -1, 0);

            // model material
            this.DefaultMaterial = new PhongMaterial
            {
                AmbientColor = Color.Gray,
                DiffuseColor = new Color4(0.75f, 0.75f, 0.75f, 1.0f), // Colors.LightGray,
                SpecularColor = Color.White,
                SpecularShininess = 100f,
                DiffuseMap = new BitmapImage(new System.Uri(@"./Media/TextureCheckerboard2.jpg", System.UriKind.RelativeOrAbsolute)),
                NormalMap = new BitmapImage(new System.Uri(@"./Media/TextureCheckerboard2_dot3.jpg", System.UriKind.RelativeOrAbsolute)),
                //DisplacementMap = new BitmapImage(new Uri(@"path", UriKind.RelativeOrAbsolute)),                
            };

            // init model
            this.MeshTopologyList = new[] { "Triangles", "Quads" };
            this.MeshTopology = "Quads";

            // floor plane grid
            this.Grid = LineBuilder.GenerateGrid();
            this.GridColor = SharpDX.Color.Black;
            this.GridTransform = new Media3D.TranslateTransform3D(-5, -1, -5);
        }

        private void LoadModel(string filename, MeshFaces faces)
        {
            // load model
            var reader = new ObjReader();
            var objModel = reader.Read(filename, new ModelInfo() { Faces = faces });
            this.DefaultModel = objModel[0].Geometry as MeshGeometry3D;
            this.DefaultModel.Colors = this.DefaultModel.Positions.Select(x => new Color4(1, 0, 0, 1)).ToArray();
        }            
    }
}
