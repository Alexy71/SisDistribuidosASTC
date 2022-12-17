<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Equipo extends Model
{
    use HasFactory;
    protected $table = 'equipos';
    protected $fillable = [
        'nombre',
        'pais', 
        'jugador_estrella',
        'puntaje'
        ];
    protected $hidden = [
        'created_at',
        'updated_at'
    ];
}
