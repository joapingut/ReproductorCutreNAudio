/*
 * Creado por SharpDevelop.
 * Usuario: Joaquin
 * Fecha: 23/06/2015
 * Hora: 22:50
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.IO;

namespace ReproductorCutre.Propios
{
	/// <summary>
	/// Description of Properties.
	/// </summary>
	public class Properties
	{
		String route;
		Dictionary<string,string> propiedades;
		
		public Properties(string route){
			this.route = route;
			this.propiedades = new Dictionary<string, string>();
		}
		
		public bool load(){
			try{
				string[] lines = System.IO.File.ReadAllLines(route);
				foreach(string line in lines){
					int res = line.IndexOf("=");
					if(res != -1){
						string key = line.Substring(0,res);
						string value = line.Substring(res + 1);
						this.propiedades.Add(key,value);
					}
				}
				return true;
			}catch{
				Console.Error.WriteLine("Properties-> No se puede leer el archivo de propiedades: " + route);
			}
			return false;
		}
		
		public string readString(string key, string defecto){
			try{
				if(this.propiedades.ContainsKey(key)){
					string res;
					this.propiedades.TryGetValue(key, out res);
					return res;
				}else{
					return defecto;
				}
			}catch{
				return defecto;
			}
		}
		
		public void putString(string key, string value){
			try{
				if(this.propiedades.ContainsKey(key)){
					this.propiedades.Remove(key);
				}
				this.propiedades.Add(key, value);
			}catch{}
		}
		
		public bool save(){
			try{
				List<string> res = new List<string>();
				foreach(string key in this.propiedades.Keys){
					string final;
					string value;
					this.propiedades.TryGetValue(key, out value);
					final = key + "=" + value;
					res.Add(final);
				}
				if(res.Count > 0){
					System.IO.File.WriteAllLines(this.route,res.ToArray());
				}else{
					return false;
				}
				return true;
			}catch{
				Console.Error.WriteLine("Properties-> No se puede leer el archivo de propiedades: " + route);
			}
			return false;
		}
	}
}
