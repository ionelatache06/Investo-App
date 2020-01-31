import { Component, OnInit } from '@angular/core';
import * as Highcharts from 'highcharts';
import HC_exporting from 'highcharts/modules/exporting';

@Component({
  selector: 'app-line2',
  templateUrl: './line2.component.html',
  styleUrls: ['./line2.component.css']
})
export class Line2Component implements OnInit {

  constructor() { }

  chartOptions: {};

  Highcharts = Highcharts;

  ngOnInit() {
    this.chartOptions = {
        chart: {
            type: 'line'
        },
        title: {
            text: 'Monthly Average Number of Users'
        },
        // subtitle: {
        //     text: 'Source: WorldClimate.com'
        // },
        xAxis: {
            categories: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec']
        },
        yAxis: {
            title: {
                text: 'Number of users  '
            }
        },
        plotOptions: {
            line: {
                dataLabels: {
                    enabled: true
                },
                enableMouseTracking: false
            }
        },
        series: [{
            name: 'All Users',
            data: [45896, 43587, 42859, 44892, 46398, 46987, 47568, 48259, 46582 , 45863, 46583, 47856]
        }, {
            name: 'New Users',
            data: [12856, 15285, 13598, 14286, 13285, 12859, 11485, 14258, 15698, 14965, 15693, 16526]
        }]
  };

  HC_exporting(Highcharts);

}

}
