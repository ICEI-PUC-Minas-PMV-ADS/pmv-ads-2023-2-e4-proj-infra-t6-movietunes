﻿using System;

public class Usuario

{
	[Key]
	public int Id { get; set; }
	[Required]
	public string Nome { get; set; }
    [Required]
    public string Password { get; set; }
    [Required]
    public Perfil Perfil { get; set; }

}

public enum Perfil

{
	[Display(Name = "Administrador")]
	Administrador,
    [Display(Name = "Usuario")]
    Usuario
}