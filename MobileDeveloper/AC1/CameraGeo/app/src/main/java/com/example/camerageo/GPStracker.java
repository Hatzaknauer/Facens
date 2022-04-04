package com.example.camerageo;

import android.Manifest;
import android.content.Context;
import android.content.pm.PackageManager;
import android.location.Location;
import android.location.LocationListener;
import android.location.LocationManager;
import android.os.Bundle;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.core.content.ContextCompat;

public class GPStracker implements LocationListener {
    Context context;

    //Aloca o contexto
    public GPStracker(Context c) {
        context = c;
    }

    //Criação do método para retornar localização
    public Location getLocation() {

        //Verifica se NÃO existe permissão para receber a localização
        if (ContextCompat.checkSelfPermission(context, Manifest.permission.ACCESS_FINE_LOCATION) !=
                PackageManager.PERMISSION_GRANTED) {

            //Retorna um aviso ao usuário de que não foi permitido o acesso a localização
            Toast.makeText(context, "Não foi permitido", Toast.LENGTH_SHORT).show();
            return null;
        }
        LocationManager lm = (LocationManager) context.getSystemService(Context.LOCATION_SERVICE);
        boolean isGPSEnabled = lm.isProviderEnabled(LocationManager.GPS_PROVIDER);

        //Se o GPS estiver habilitado requisita ao provedor a ultima localização e "retorna" a mesma
        if(isGPSEnabled) {
            lm.requestLocationUpdates(LocationManager.GPS_PROVIDER, 6000, 10, this);
            Location l = lm.getLastKnownLocation(LocationManager.GPS_PROVIDER);
            return l;
        } else{

            //Se GPS não estiver habilitado, pede ao usuário para que ligue o GPS
            Toast.makeText(context, "Por favor, habitar o GPS!", Toast.LENGTH_LONG).show();
        }

        //E não retorna nada porque não tem GPS ligado
        return null;
    }

    //Faz com que o parâmetro provider não seja nulo
    @Override
    public void onProviderDisabled(@NonNull String provider) {
    }

    //Faz com que o parâmetro location não seja nulo
    @Override
    public void onLocationChanged(@NonNull Location location) {
    }

    //Recebe as mudanças de status sobrepondo ao método
    @Override
    public void onStatusChanged(String provider, int status, Bundle extras) {
    }
}
