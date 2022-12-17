<?php

namespace Database\Factories;

use Illuminate\Database\Eloquent\Factories\Factory;

class EquipoFactory extends Factory
{
    /**
     * Define the model's default state.
     *
     * @return array
     */
    public function definition()
    {
        return [
            'nombre' => $this->faker->name,
            'pais' => $this->faker->country,
            'jugador_estrella' => $this->faker->city,
            'puntaje' => $this->faker->numberBetween(1, 20),

        ];
    }
}
