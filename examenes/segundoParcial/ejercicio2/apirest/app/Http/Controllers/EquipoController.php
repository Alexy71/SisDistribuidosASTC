<?php

namespace App\Http\Controllers;

use App\Models\Equipo;
use Illuminate\Http\Request;
use App\Http\Requests\EquipoRequest;

class EquipoController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        return  response()->json(Ciudad::all(), 200);
    }

    public function store(EquipoRequest $request)
    {
        $equipo = Equipo::create($request->all());

        return response()->json(
            ["transaccion" => true, 
             "mensaje" => "Ciudad creada",
             "response" => $equipo],
            201
        );
    }

    /**
     * Display the specified resource.
     *
     * @param  \App\Models\Equipo  $equipo
     * @return \Illuminate\Http\Response
     */
    public function show(Equipo $equipo)
    {
        return response()->json($equipo, 200);
    }

    /**
     * Show the form for editing the specified resource.
     *

    /**
     * Update the specified resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @param  \App\Models\Equipo  $equipo
     * @return \Illuminate\Http\Response
     */
    public function update(Request $request, Equipo $equipo)
    {
        $equipo->update($request->all());
        return response()->json($equipo, 200);
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  \App\Models\Equipo  $equipo
     * @return \Illuminate\Http\Response
     */
    public function destroy(Equipo $equipo)
    {
        //
    }
}
