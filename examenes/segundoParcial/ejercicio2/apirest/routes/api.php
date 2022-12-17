<?php

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;
use App\Http\Controllers\EquipoController;
use App\Http\Controllers\SeguridadController;

Route::group(['middleware' => ['jwt.verify']], function () {

Route::get('/equipo',[EquipoController::class,'index']);
Route::get('/equipo/{equipo}',[EquipoController::class,'show']);
Route::post('/equipo',[EquipoController::class,'store']);
Route::put('/equipo/{equipo}',[EquipoController::class,'update']);
Route::delete('/equipo/{equipo}',[EquipoController::class,'destroy']);
});


Route::post('/login',[SeguridadController::class,'login']);
