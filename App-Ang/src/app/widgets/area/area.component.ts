import { Component, OnInit } from '@angular/core';
import * as Highcharts from 'highcharts';
import HC_exporting from 'highcharts/modules/exporting';


@Component({
  selector: 'app--widget-area',
  templateUrl: './area.component.html',
  styleUrls: ['./area.component.css']
})
export class AreaComponent implements OnInit {

  constructor() { }

  chartOptions: {};

  Highcharts = Highcharts;

  ngOnInit() {
      this.chartOptions = {
        chart: {
          type: 'area'
      },
      title: {
          text: '2019 Sales Evolution by Quarter & Region'
      },
      // subtitle: {
      //     text: 'Source: '
      // },
      xAxis: {
          categories: ['Q1', 'Q2', 'Q3', 'Q4'],
          tickmarkPlacement: 'on',
          title: {
              enabled: false
          }
      },
      yAxis: {
          title: {
              text: 'Dollars'
          },
          labels: {
              formatter: function () {
                  return this.value / 1000;
              }
          }
      },
      tooltip: {
          split: true,
          valueSuffix: ' dollars'
      },
      plotOptions: {
          area: {
              stacking: 'normal',
              lineColor: '#666666',
              lineWidth: 1,
              marker: {
                  lineWidth: 1,
                  lineColor: '#666666'
              }
          }
      },
      series: [{
          name: 'Asia',
          data: [502000, 635000, 809000, 947000]
      }, {
          name: 'Africa',
          data: [106000, 107000, 111000, 133000]
      }, {
          name: 'Europe',
          data: [163000, 203000, 276000, 408000]
      }, {
          name: 'America',
          data: [180000, 310000, 540000, 156000]
      }, {
          name: 'Oceania',
          data: [20000, 200000, 200000, 60000]
      }]
  };

  HC_exporting(Highcharts);
   
  }

}
