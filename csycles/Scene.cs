﻿/**
Copyright 2014 Robert McNeel and Associates

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
**/

using System.Collections.Generic;
using System.Linq;

namespace ccl
{
	/// <summary>
	/// The Cycles scene representation
	/// </summary>
	public class Scene
	{
		/// <summary>
		/// Get the ID of the created Scene
		/// </summary>
		public uint Id { get; private set; }

		/// <summary>
		/// Client ID for CCycles API
		/// </summary>
		internal Client Client { get; set; }

		/// <summary>
		/// Access to the Camera for this Scene
		/// </summary>
		public Camera Camera { get; private set; }

		/// <summary>
		/// Access to the Integrator settings for this Scene
		/// </summary>
		public Integrator Integrator { get; private set; }

		/// <summary>
		/// Access to the Bacground settings for this Scene
		/// </summary>
		public Background Background { get; private set; }

		/// <summary>
		/// Create a new scene with the given SceneParameters and Device
		/// </summary>
		/// <param name="clientId">The client ID from C[CS]ycles API</param>
		/// <param name="sceneParams">The SceneParameters to create scene with</param>
		/// <param name="device">The Device to create scene for</param>
		public Scene(Client client, SceneParameters sceneParams, Device device)
		{
			Client = client;
			Id = CSycles.scene_create(Client.Id, sceneParams.Id, device.Id);
			Background = new Background(this);
			Camera = new Camera(this);
			Integrator = new Integrator(this);

			client.Scene = this;
		}

		/// <summary>
		/// A mapping of shaders and their scene specific IDs.
		/// </summary>
		private Dictionary<Shader, uint> shaders = new Dictionary<Shader, uint>();
		/// <summary>
		/// Add a Shader to Scene, assigning it a scene specific ID.
		/// </summary>
		/// <param name="shader">The Shader to add to the Scene</param>
		/// <returns>Scene-specific ID for the Shader</returns>
		public uint AddShader(Shader shader)
		{
			var shader_in_scene_id = CSycles.scene_add_shader(Client.Id, Id, shader.Id);
			shaders.Add(shader, shader_in_scene_id);
			return shader_in_scene_id;
		}

		/// <summary>
		/// Get the scene-specific Id for Shader
		/// </summary>
		/// <param name="shader">Shader to query for</param>
		/// <returns>Scene-specific Id</returns>
		public uint ShaderSceneId(Shader shader)
		{
			return shaders[shader];
		}

		public Shader ShaderFromSceneId(uint shaderId)
		{
			foreach (var kvp in shaders)
			{
				if (kvp.Value == shaderId)
				{
					return kvp.Key;
				}
			}

			return null;
		}

		public Shader ShaderWithName(string name)
		{
			return (from kvp in shaders where kvp.Key.Name.Equals(name) select kvp.Key).FirstOrDefault();
		}

		/// <summary>
		/// Get a shader based on Scene-specific ID.
		/// 
		/// \todo devise a way to wrap Cycles' default shaders (surface, light, background).
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		private Shader GetShader(uint id)
		{
			foreach (var kvp in shaders)
			{
				if (kvp.Value == id)
				{
					return kvp.Key;
				}
			}

			return null;
		}

		/// <summary>
		/// Get or set the default surface shader for this scene.
		/// </summary>
		public Shader DefaultSurface
		{
			get
			{
				return GetShader(CSycles.scene_get_default_surface_shader(Client.Id, Id));
			}
			set
			{
				CSycles.scene_set_default_surface_shader(Client.Id, Id, ShaderSceneId(value));
			}
		}
		//public static uint scene_create(uint scene_params_id, uint deviceid)
		//public static uint scene_add_object(uint scene_id)
		//public static uint scene_add_mesh(uint scene_id, uint object_id, uint shader_id)
		//public static void scene_set_default_surface_shader(uint scene_id, uint shader_id)
	}
}
